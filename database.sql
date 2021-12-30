-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.22-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for sistem_penitipan_barang
DROP DATABASE IF EXISTS `sistem_penitipan_barang`;
CREATE DATABASE IF NOT EXISTS `sistem_penitipan_barang` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `sistem_penitipan_barang`;

-- Dumping structure for table sistem_penitipan_barang.jenis_ukuran
DROP TABLE IF EXISTS `jenis_ukuran`;
CREATE TABLE IF NOT EXISTS `jenis_ukuran` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `ukuran` varchar(255) NOT NULL,
  `biaya` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.jenis_ukuran: ~3 rows (approximately)
DELETE FROM `jenis_ukuran`;
/*!40000 ALTER TABLE `jenis_ukuran` DISABLE KEYS */;
INSERT INTO `jenis_ukuran` (`id`, `ukuran`, `biaya`) VALUES
	(1, 'Kecil', 10000),
	(2, 'Sedang', 20000),
	(3, 'Besar', 30000);
/*!40000 ALTER TABLE `jenis_ukuran` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.locker
DROP TABLE IF EXISTS `locker`;
CREATE TABLE IF NOT EXISTS `locker` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_ukuran` int(10) NOT NULL,
  `lokasi` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL DEFAULT 'Kosong',
  PRIMARY KEY (`id`),
  KEY `locker_jenis_ukuran_fk` (`id_ukuran`),
  CONSTRAINT `locker_jenis_ukuran_fk` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.locker: ~9 rows (approximately)
DELETE FROM `locker`;
/*!40000 ALTER TABLE `locker` DISABLE KEYS */;
INSERT INTO `locker` (`id`, `id_ukuran`, `lokasi`, `status`) VALUES
	(1, 1, 'AA', 'Kosong'),
	(2, 1, 'AA', 'Kosong'),
	(3, 1, 'AA', 'Kosong'),
	(4, 2, 'AB', 'Kosong'),
	(5, 2, 'AB', 'Kosong'),
	(6, 2, 'AB', 'Kosong'),
	(7, 3, 'BA', 'Kosong'),
	(8, 3, 'BA', 'Kosong'),
	(9, 3, 'BB', 'Kosong');
/*!40000 ALTER TABLE `locker` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.penyewaan
DROP TABLE IF EXISTS `penyewaan`;
CREATE TABLE IF NOT EXISTS `penyewaan` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_locker` int(10) NOT NULL,
  `tanggal_sewa` datetime NOT NULL,
  `tanggal_kembali` datetime DEFAULT NULL,
  `bayar_sebelum_pinjam` int(10) NOT NULL DEFAULT 0,
  `rencana_pinjam` int(10) NOT NULL,
  `kelebihan_pinjam` int(10) NOT NULL DEFAULT 0,
  `total_bayar` int(10) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `penyewaan_locker_fk` (`id_locker`),
  CONSTRAINT `penyewaan_locker_fk` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.penyewaan: ~1 rows (approximately)
DELETE FROM `penyewaan`;
/*!40000 ALTER TABLE `penyewaan` DISABLE KEYS */;
/*!40000 ALTER TABLE `penyewaan` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.users: ~2 rows (approximately)
DELETE FROM `users`;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
	(1, 'admin', 'contact@admin.com', '21232f297a57a5a743894a0e4a801fc3');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
