-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.22-MariaDB-log - mariadb.org binary distribution
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
CREATE DATABASE IF NOT EXISTS `sistem_penitipan_barang` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `sistem_penitipan_barang`;

-- Dumping structure for table sistem_penitipan_barang.jenis_ukuran
CREATE TABLE IF NOT EXISTS `jenis_ukuran` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `ukuran` varchar(255) NOT NULL,
  `biaya` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.jenis_ukuran: ~0 rows (approximately)
/*!40000 ALTER TABLE `jenis_ukuran` DISABLE KEYS */;
INSERT INTO `jenis_ukuran` (`id`, `ukuran`, `biaya`) VALUES
	(1, 'Kecil', 10000),
	(2, 'Sedang', 20000),
	(3, 'Besar', 30000);
/*!40000 ALTER TABLE `jenis_ukuran` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.locker
CREATE TABLE IF NOT EXISTS `locker` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `id_ukuran` int(10) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `lokasi` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL DEFAULT 'Kosong',
  PRIMARY KEY (`id`),
  KEY `locker_jenis_ukuran_fk` (`id_ukuran`),
  CONSTRAINT `locker_jenis_ukuran_fk` FOREIGN KEY (`id_ukuran`) REFERENCES `jenis_ukuran` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.locker: ~1 rows (approximately)
/*!40000 ALTER TABLE `locker` DISABLE KEYS */;
INSERT INTO `locker` (`id`, `id_ukuran`, `nama`, `lokasi`, `status`) VALUES
	(1, 1, 'K101', 'Lantai 1', 'Kosong'),
	(2, 1, 'K102', 'Lantai 1', 'Kosong'),
	(3, 2, 'S101', 'Lantai 1', 'Kosong'),
	(4, 2, 'S102', 'Lantai 1', 'Kosong'),
	(5, 3, 'B201', 'Lantai 2', 'Kosong'),
	(6, 3, 'B202', 'Lantai 2', 'Kosong');
/*!40000 ALTER TABLE `locker` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.penyewaan
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
  CONSTRAINT `penyewaan_locker_fk` FOREIGN KEY (`id_locker`) REFERENCES `locker` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.penyewaan: ~0 rows (approximately)
/*!40000 ALTER TABLE `penyewaan` DISABLE KEYS */;
INSERT INTO `penyewaan` (`id`, `id_locker`, `tanggal_sewa`, `tanggal_kembali`, `bayar_sebelum_pinjam`, `rencana_pinjam`, `kelebihan_pinjam`, `total_bayar`) VALUES
	(1, 4, '2022-01-18 21:24:55', '2022-01-18 11:34:06', 20000, 1, 44000, 64000),
	(2, 5, '2022-01-18 23:34:21', '2022-01-18 11:34:30', 30000, 1, 0, 30000),
	(3, 1, '2022-01-18 23:40:10', '2022-01-18 11:40:27', 10000, 1, 0, 10000);
/*!40000 ALTER TABLE `penyewaan` ENABLE KEYS */;

-- Dumping structure for table sistem_penitipan_barang.users
CREATE TABLE IF NOT EXISTS `users` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table sistem_penitipan_barang.users: ~0 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id`, `username`, `email`, `password`) VALUES
	(1, 'admin', 'admin@contact.me', '21232f297a57a5a743894a0e4a801fc3');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
