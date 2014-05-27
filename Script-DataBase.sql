SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

DROP SCHEMA IF EXISTS `ine_bancos` ;
CREATE SCHEMA IF NOT EXISTS `ine_bancos` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `ine_bancos` ;

-- -----------------------------------------------------
-- Table `ine_bancos`.`banco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`banco` (
  `idbanco` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `telefono` VARCHAR(45) NULL,
  `direccion` VARCHAR(45) NULL,
  PRIMARY KEY (`idbanco`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`tipo_cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`tipo_cuenta` (
  `idtipo_cuenta` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `descripcion` TEXT NULL,
  PRIMARY KEY (`idtipo_cuenta`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`moneda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`moneda` (
  `idmoneda` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `descripcion` VARCHAR(45) NULL,
  PRIMARY KEY (`idmoneda`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`cuenta` (
  `idcuenta` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `numero` VARCHAR(45) NULL,
  `estado` INT NULL,
  `saldo` FLOAT(7,2) NULL,
  `idtipo_cuenta` INT NOT NULL,
  `idbanco` INT NOT NULL,
  `idmoneda` INT NOT NULL,
  PRIMARY KEY (`idcuenta`),
  INDEX `fk_cuenta_tipo_cuenta1_idx` (`idtipo_cuenta` ASC),
  INDEX `fk_cuenta_banco1_idx` (`idbanco` ASC),
  INDEX `fk_cuenta_moneda1_idx` (`idmoneda` ASC),
  CONSTRAINT `fk_cuenta_tipo_cuenta1`
    FOREIGN KEY (`idtipo_cuenta`)
    REFERENCES `ine_bancos`.`tipo_cuenta` (`idtipo_cuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuenta_banco1`
    FOREIGN KEY (`idbanco`)
    REFERENCES `ine_bancos`.`banco` (`idbanco`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cuenta_moneda1`
    FOREIGN KEY (`idmoneda`)
    REFERENCES `ine_bancos`.`moneda` (`idmoneda`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`departamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`departamento` (
  `iddepartamento` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `descripcion` TEXT NULL,
  PRIMARY KEY (`iddepartamento`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`tipo_agente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`tipo_agente` (
  `idtipo_agente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `descripcion` TEXT NULL,
  PRIMARY KEY (`idtipo_agente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`agente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`agente` (
  `idagente` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `direccion` VARCHAR(100) NULL,
  `telefono` VARCHAR(45) NULL,
  `nit` VARCHAR(15) NULL,
  `idtipo_agente` INT NOT NULL,
  PRIMARY KEY (`idagente`),
  INDEX `fk_agente_tipo_agente1_idx` (`idtipo_agente` ASC),
  CONSTRAINT `fk_agente_tipo_agente1`
    FOREIGN KEY (`idtipo_agente`)
    REFERENCES `ine_bancos`.`tipo_agente` (`idtipo_agente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`tipo_transaccion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`tipo_transaccion` (
  `idtipo_transaccion` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  PRIMARY KEY (`idtipo_transaccion`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`transaccion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`transaccion` (
  `idtransaccion` INT NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL,
  `clave` VARCHAR(45) NULL,
  `descripcion` TEXT NULL,
  `idtipo_transaccion` INT NOT NULL,
  PRIMARY KEY (`idtransaccion`),
  INDEX `fk_transaccion_tipo_transaccion1_idx` (`idtipo_transaccion` ASC),
  CONSTRAINT `fk_transaccion_tipo_transaccion1`
    FOREIGN KEY (`idtipo_transaccion`)
    REFERENCES `ine_bancos`.`tipo_transaccion` (`idtipo_transaccion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`movimiento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`movimiento` (
  `idmovimiento` INT NOT NULL AUTO_INCREMENT,
  `idcuenta` INT NOT NULL,
  `monto` FLOAT(7,2) NULL,
  `fecha` DATE NULL,
  `referencia` VARCHAR(45) NULL,
  `idtransaccion` INT NOT NULL,
  PRIMARY KEY (`idmovimiento`, `idcuenta`),
  INDEX `fk_transaccion_transaccion1_idx` (`idtransaccion` ASC),
  CONSTRAINT `fk_transaccion_cuenta1`
    FOREIGN KEY (`idcuenta`)
    REFERENCES `ine_bancos`.`cuenta` (`idcuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_transaccion_transaccion1`
    FOREIGN KEY (`idtransaccion`)
    REFERENCES `ine_bancos`.`transaccion` (`idtransaccion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`agenda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`agenda` (
  `idagenda` INT NOT NULL AUTO_INCREMENT,
  `idcuenta` INT NOT NULL,
  `dia` INT NULL,
  `monto` FLOAT(7,2) NULL,
  `descripcion` TEXT NULL,
  `mes` INT NULL,
  `idtransaccion` INT NOT NULL,
  PRIMARY KEY (`idagenda`, `idcuenta`),
  INDEX `fk_agenda_cuenta1_idx` (`idcuenta` ASC),
  INDEX `fk_agenda_transaccion1_idx` (`idtransaccion` ASC),
  CONSTRAINT `fk_agenda_cuenta1`
    FOREIGN KEY (`idcuenta`)
    REFERENCES `ine_bancos`.`cuenta` (`idcuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_agenda_transaccion1`
    FOREIGN KEY (`idtransaccion`)
    REFERENCES `ine_bancos`.`transaccion` (`idtransaccion`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `ine_bancos`.`cheque`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ine_bancos`.`cheque` (
  `idcheque` INT NOT NULL,
  `idcuenta` INT NOT NULL,
  `fecha` DATE NULL,
  `valor` FLOAT(7,2) NULL,
  `concepto` TEXT NULL,
  `beneficiario` VARCHAR(45) NULL,
  `impreso` INT NULL,
  `idagente` INT NOT NULL,
  PRIMARY KEY (`idcheque`, `idcuenta`),
  INDEX `fk_cheque_cuenta1_idx` (`idcuenta` ASC),
  INDEX `fk_cheque_agente1_idx` (`idagente` ASC),
  CONSTRAINT `fk_cheque_cuenta1`
    FOREIGN KEY (`idcuenta`)
    REFERENCES `ine_bancos`.`cuenta` (`idcuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_cheque_agente1`
    FOREIGN KEY (`idagente`)
    REFERENCES `ine_bancos`.`agente` (`idagente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

use ine_bancos;

INSERT INTO `banco` (`idbanco`, `nombre`, `telefono`, `direccion`) VALUES
(1, 'Banco Industrial', '2555523', 'Zona 4'),
(5, 'Banco Agromercantil', '2222222', 'Zona 11'),
(6, 'Banco Banrural', '664324234', 'Zona 12');

INSERT INTO `tipo_cuenta` (`idtipo_cuenta`, `nombre`, `descripcion`) VALUES
(1, 'Monetaria', 'No tiene porcentaje de ganancia');

INSERT INTO `moneda` (`idmoneda`, `nombre`, `descripcion`) VALUES
(1, 'Quetzal', 'Guatemala');

INSERT INTO `cuenta` (`idcuenta`, `nombre`, `numero`, `estado`, `saldo`, `idtipo_cuenta`, `idbanco`, `idmoneda`) VALUES
(1, 'Empresa Sociedad Anónima, Guatemala', '445454232-2', NULL, NULL, 1, 5, 1);

INSERT INTO `tipo_agente` (`idtipo_agente`, `nombre`, `descripcion`) VALUES
(1, 'Cliente', NULL),
(2, 'Proveedor', NULL),
(3, 'Acreedor', NULL);

INSERT INTO `tipo_transaccion` (`idtipo_transaccion`, `nombre`) VALUES
(1, 'Abono'),
(2, 'Cargo');

INSERT INTO `transaccion` (`idtransaccion`, `nombre`, `clave`, `descripcion`, `idtipo_transaccion`) VALUES
(1, 'Depósito monetario', 'DEP', 'Depósito a nuestra cuenta monetaria', 1);

INSERT INTO `agente` (`idagente`, `nombre`, `direccion`, `telefono`, `nit`, `idtipo_agente`) VALUES
(2, 'Junito', 'Guatemala', '2342342', '324242-2', 1);
