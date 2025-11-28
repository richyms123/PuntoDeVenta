-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Ventas
-- -----------------------------------------------------
-- Base de datos para punto de venta de una panaderia.

-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Ventas` DEFAULT CHARACTER SET utf8 COLLATE utf8_bin ;
USE `Ventas` ;

-- -----------------------------------------------------
-- Table `Ventas`.`Empleados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`Empleados` (
  `idEmpleado` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(50) NOT NULL,
  `Apellidos` VARCHAR(50) NOT NULL,
  `Rol` TINYINT(1) NOT NULL DEFAULT '0' COMMENT 'Valor de 1 para usuarios administradores, valor de 0 para usuarios empleados.',
  `Usuario` VARCHAR(30) NOT NULL,
  `Pasword` NVARCHAR(255) NOT NULL,
  `Turno` ENUM('Matutino', 'Vespertino') NOT NULL,
  `FechaNacimiento` DATETIME NOT NULL,
  `Direccion` VARCHAR(60) NOT NULL,
  `Municipio` VARCHAR(25) NOT NULL,
  `Estado` VARCHAR(25) NOT NULL,
  `CodigoPostal` VARCHAR(10) NOT NULL,
  `Pais` VARCHAR(15) NOT NULL,
  `Telefono` CHAR(10) NOT NULL,
  `eMaill` VARCHAR(100) NOT NULL,
  `FotoEmpleado` VARCHAR(255) NULL DEFAULT NULL COMMENT 'Almacena la ruta de la imagen.',
  `FechaDeAlta` DATETIME NOT NULL,
  PRIMARY KEY (`idEmpleado`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ventas`.`Ventas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`Ventas` (
  `idVenta` INT NOT NULL,
  `Fecha` DATETIME NOT NULL,
  `Estatus` ENUM('Pagada', 'Cancelada') NOT NULL,
  `MetodoPago` ENUM('Efectivo', 'Tarjeta', 'Transferencia') NOT NULL,
  `Total` DECIMAL(9,2) NOT NULL,
  `idEmpleado` INT NOT NULL,
  PRIMARY KEY (`idVenta`),
  INDEX `fk_Ventas_Empleados1_idx` (`idEmpleado` ASC) VISIBLE,
  CONSTRAINT `fk_Ventas_Empleados1`
    FOREIGN KEY (`idEmpleado`)
    REFERENCES `Ventas`.`Empleados` (`idEmpleado`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ventas`.`Categorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`Categorias` (
  `idCategoria` INT NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Descripcion` TINYTEXT NOT NULL,
  PRIMARY KEY (`idCategoria`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ventas`.`Productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`Productos` (
  `idProducto` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(40) NOT NULL,
  `CantidadPorUnidad` VARCHAR(20) NULL DEFAULT NULL,
  `PrecioUnitario` DECIMAL(6,2) NOT NULL,
  `UnidadesEnStock` SMALLINT NULL DEFAULT '0',
  `Descontinuado` TINYINT(1) NOT NULL DEFAULT '0',
  `FotoProducto` VARCHAR(255) NULL,
  `idCategoria` INT NOT NULL,
  PRIMARY KEY (`idProducto`),
  INDEX `fk_Productos_Categorias1_idx` (`idCategoria` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_Categorias1`
    FOREIGN KEY (`idCategoria`)
    REFERENCES `Ventas`.`Categorias` (`idCategoria`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ventas`.`DetalleVenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`DetalleVenta` (
  `idProducto` INT NOT NULL,
  `idVenta` INT NOT NULL,
  `PrecioUnitario` DECIMAL(6,2) NOT NULL,
  `Cantidad` SMALLINT NOT NULL,
  `Descuento` FLOAT NOT NULL DEFAULT '0',
  `SubTotal` DECIMAL(9,2) NOT NULL,
  PRIMARY KEY (`idProducto`, `idVenta`),
  INDEX `fk_Productos_has_Ventas_Ventas1_idx` (`idVenta` ASC) VISIBLE,
  INDEX `fk_Productos_has_Ventas_Productos_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_Productos_has_Ventas_Productos`
    FOREIGN KEY (`idProducto`)
    REFERENCES `Ventas`.`Productos` (`idProducto`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT,
  CONSTRAINT `fk_Productos_has_Ventas_Ventas1`
    FOREIGN KEY (`idVenta`)
    REFERENCES `Ventas`.`Ventas` (`idVenta`)
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ventas`.`AuditoriaProductos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ventas`.`AuditoriaProductos` (
  `idAuditoria` INT NOT NULL,
  `FechaDeCambio` TIMESTAMP NOT NULL,
  `TipoCambio` ENUM('Insert', 'Update', 'Delete') NOT NULL,
  `Usuario` VARCHAR(50) NOT NULL,
  `ValorAnterior` DECIMAL(6,2) NOT NULL,
  `ValorNuevo` DECIMAL(6,2) NOT NULL,
  `idProducto` INT NOT NULL,
  PRIMARY KEY (`idAuditoria`),
  INDEX `fk_AuditoriaProductos_Productos1_idx` (`idProducto` ASC) VISIBLE,
  CONSTRAINT `fk_AuditoriaProductos_Productos1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `Ventas`.`Productos` (`idProducto`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
