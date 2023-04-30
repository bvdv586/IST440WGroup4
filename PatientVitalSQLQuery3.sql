CREATE TABLE Patient
(
	[patientID] INT NOT NULL PRIMARY KEY, 
    [medicalRecordNumber] INT NOT NULL, 
    [firstName] NCHAR(20) NOT NULL, 
    [lastName] NCHAR(20) NOT NULL, 
    [dateOfBirth] NCHAR(20) NOT NULL, 
    [dateOfAdmission] NCHAR(20) NOT NULL, 
    [dateOfDischarge] NCHAR(20) NULL, 
    [location] NCHAR(50) NOT NULL, 
    [careTeam] INT NOT NULL, 
    [diagnosis] NVARCHAR(MAX) NOT NULL, 
    [admittingClinicianID] INT NOT NULL, 
    [attendingClinicianID] INT NOT NULL, 
    [hospitalWing] NCHAR(10) NOT NULL, 
    [roomNumber] NCHAR(10) NOT NULL,   
    [respiratoryRPM] INT NOT NULL, 
    [heartRate] INT NOT NULL, 
    [systolicBP] INT NOT NULL, 
    [apvuScore] NCHAR(20) NOT NULL, 
    [temperature] INT NOT NULL, 
)


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (1, 1, 'Brian', 'Smith', '01/23/1970', '03/01/2022', NULL, 'Good Patient Hospital', 1, 'T63083A - TOXIC EFFECT OF', 19778, 106336, 'SUR', 'ED01', 10, 58, 102, 'ALERT', 35);

INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (2, 2,'Jeffrey', 'Jefferson', '02/25/1975', '03/01/2022', NULL, 'Good Patient Hospital', 1, 'T63083A - TOXIC EFFECT OF', 19780, 56671, 'SUR', 'ED02', 9, 100, 58, 'PAIN', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (3, 3, 'Anthony', 'Tony', '03/19/1989', '3/1/2022', NULL, 'Good Patient Hospital', 3, 'K50.013 - CROHN’S DISEASE', 19782, 2808, 'EMG', 'ED03', 20, 99, 50, 'VOICE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (4, 4, 'Myra', 'Stewie', '05/29/1987', '3/1/2022', NULL, 'Good Patient Hospital', 1, 'K71.51 - TOXIC LIVER DISE', 19784, 2097, 'SUR', 'ED04', 12, 130, 99, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (5, 5, 'Jason', 'Json', '06/15/1955', '2/1/2022', NULL, 'Good Patient Hospital', 3, 'B6309A - MUSCLE SPASMS', 19786, 2063, 'SUR', 'ED05', 7, 112, 200, 'AGITATED', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (6, 6, 'Nicky', 'Barnes', '07/23/1979', '3/1/2022', NULL, 'Good Patient Hospital', 1, 'TYPHOID FEVER', 19788, 301212, 'RAD', 'ED06', 15, 39, 50, 'UNRESPONSIVE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (7, 7, 'Guy', 'Aldente', '08/01/1980', '3/2/2022', NULL, 'Good Patient Hospital', 1, 'B6309A - MUSCLE SPASMS', 19778, 301208, 'SUR', 'ED07', 9, 40, 66, 'UNRESPONSIVE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (8, 8, 'Sara', 'Calling', '09/26/1995', '3/2/2022', NULL, 'Good Patient Hospital', 3, 'B6309A - MUSCLE SPASMS', 19778, 303840, 'SUR', 'ED08', 12, 58, 105, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (9, 9, 'Amy', 'Amal', '10/20/1964', '3/2/2022', NULL, 'Good Patient Hospital', 4, 'B6309A - MUSCLE SPASMS', 19778, 106336, 'SUR', 'ED09', 12, 58, 102, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (10, 10, 'Christina', 'Coalmine', '06/18/2018', '2/1/2022', NULL, 'Good Patient Hospital', 1, 'B6309A - MUSCLE SPASMS', 19778, 303760, 'SUR', 'ED10', 7, 100, 58, 'PAIN', 35);

INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (11, 11, 'Betty', 'Soon', '12/12/1993','3/2/2022', NULL, 'Good Patient Hospital', 4, 'B6309A - MUSCLE SPASMS', 19780, 66183, 'SUR', 'ED11', 15, 99, 50, 'VOICE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (12, 12, 'Milly', 'Millsanta', '01/17/1977', '3/2/2022', NULL, 'Good Patient Hospital', 4, 'T63083A - TOXIC EFFECT OF', 19782, 105353, 'SUR', 'ED12', 9, 130, 99, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (13, 13, 'Caemella', 'Carmine', '02/08/1962', '3/2/2022', NULL, 'Good Patient Hospital', 3, 'T63083A - TOXIC EFFECT OF', 19784, 301439, 'RAD', 'ED13', 20, 112, 200, 'AGITATED', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (14, 14, 'Vito', 'Ferndale', '03/03/1985', '5/23/2022', NULL, 'Good Patient Hospital', 1, 'T63083A - TOXIC EFFECT OF', 19786, 303173, 'SUR', 'ED14', 12, 39, 50, 'UNRESPONSIVE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (15, 15, 'Brian', 'Doe', '01/23/1970', '3/2/2022', NULL, 'Good Patient Hospital', 1, 'CHOLERA', 19788, 302434, 'SUR', 'ED15', 7, 40, 66, 'UNRESPONSIVE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (16, 16, 'John','Johhny', '04/03/1967', '3/2/2022', NULL, 'Good Patient Hospital', 1, 'E11.41 - TYPE 2 DIABETES', 19778, 37028, 'SUR', 'ED16', 15, 58, 105, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (17, 17, 'Joseph', 'Josephman', '02/25/2020', '3/2/2022', NULL, 'Good Patient Hospital', 4, 'T63083A - TOXIC EFFECT OF', 19778, 270686, 'SUR', 'ED20', 7, 130, 99, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (18, 18, 'Teresa', 'Terry', '07/12/1958', '3/5/2022', NULL, 'Good Patient Hospital', 1, 'T63083A - TOXIC EFFECT OF', 19778, 28001, 'SUR', 'ED24', 2, 58, 105, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (19, 19, 'Bart', 'Bravery', '12/02/2000', '3/6/2022', NULL, 'Good Patient Hospital', 2, 'T63083A - TOXIC EFFECT OF', 19780, 19067, 'SUR', 'ED25', 15, 58, 102, 'ALERT', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (20, 20, 'John', 'Jacobsand', '12/03/1921', '3/6/2022', NULL, 'Good Patient Hospital', 4, 'T63083A - TOXIC EFFECT OF', 19782, 106088, 'SUR', 'ED26', 30, 100, 58, 'PAIN', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (21, 21, 'Brian', 'Nostradamus', '12/06/1960', '3/6/2022', NULL, 'Good Patient Hospital', 4, 'T63083A - TOXIC EFFECT OF', 19784, 62901, 'SUR', 'ED27', 12, 99, 50, 'VOICE', 35);


INSERT INTO Patient (patientID, medicalRecordNumber, firstName, lastName, dateOfBirth, dateOfAdmission, dateOfDischarge, location, careTeam, diagnosis, admittingClinicianID, attendingClinicianID, hospitalWing, roomNumber, respiratoryRPM, heartRate, systolicBP, apvuScore, temperature)

VALUES (22, 22, 'Ken', 'Barbie', '12/06/1976', '3/6/2022', NULL	, 'Good Patient Hospital', 3, 'T63083A - TOXIC EFFECT OF', 19786, 30247, 'SUR', 'ED28', 7, 130, 99, 'ALERT', 35);