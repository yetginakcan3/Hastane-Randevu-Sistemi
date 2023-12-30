using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital.Repositories.Migrations
{
    public partial class AddDoctorToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_PatientId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Insurances_InsuranceId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Hospitals_HospitalId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_AspNetUsers_PatientId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientReport_AspNetUsers_DoctorId",
                table: "PatientReport");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientReport_AspNetUsers_PatientId",
                table: "PatientReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeIdId",
                table: "Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicines_Medicines_MedicineId",
                table: "PrescribedMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicines_PatientReport_PatientReportId",
                table: "PrescribedMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_TestPrices_Bills_BillId",
                table: "TestPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_TestPrices_Labs_LabId",
                table: "TestPrices");

            migrationBuilder.AddColumn<bool>(
                name: "IsDoctor",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AspNetUsers_PatientId",
                table: "Bills",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Insurances_InsuranceId",
                table: "Bills",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Hospitals_HospitalId",
                table: "Contacts",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_AspNetUsers_PatientId",
                table: "Labs",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientReport_AspNetUsers_DoctorId",
                table: "PatientReport",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientReport_AspNetUsers_PatientId",
                table: "PatientReport",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeIdId",
                table: "Payrolls",
                column: "EmployeeIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicines_Medicines_MedicineId",
                table: "PrescribedMedicines",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicines_PatientReport_PatientReportId",
                table: "PrescribedMedicines",
                column: "PatientReportId",
                principalTable: "PatientReport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestPrices_Bills_BillId",
                table: "TestPrices",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TestPrices_Labs_LabId",
                table: "TestPrices",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AspNetUsers_PatientId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Insurances_InsuranceId",
                table: "Bills");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Hospitals_HospitalId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_AspNetUsers_PatientId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientReport_AspNetUsers_DoctorId",
                table: "PatientReport");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientReport_AspNetUsers_PatientId",
                table: "PatientReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeIdId",
                table: "Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicines_Medicines_MedicineId",
                table: "PrescribedMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescribedMedicines_PatientReport_PatientReportId",
                table: "PrescribedMedicines");

            migrationBuilder.DropForeignKey(
                name: "FK_TestPrices_Bills_BillId",
                table: "TestPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_TestPrices_Labs_LabId",
                table: "TestPrices");

            migrationBuilder.DropColumn(
                name: "IsDoctor",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AspNetUsers_PatientId",
                table: "Bills",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Insurances_InsuranceId",
                table: "Bills",
                column: "InsuranceId",
                principalTable: "Insurances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Hospitals_HospitalId",
                table: "Contacts",
                column: "HospitalId",
                principalTable: "Hospitals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_AspNetUsers_PatientId",
                table: "Labs",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PatientReport_AspNetUsers_DoctorId",
                table: "PatientReport",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientReport_AspNetUsers_PatientId",
                table: "PatientReport",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payrolls_AspNetUsers_EmployeeIdId",
                table: "Payrolls",
                column: "EmployeeIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicines_Medicines_MedicineId",
                table: "PrescribedMedicines",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescribedMedicines_PatientReport_PatientReportId",
                table: "PrescribedMedicines",
                column: "PatientReportId",
                principalTable: "PatientReport",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestPrices_Bills_BillId",
                table: "TestPrices",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestPrices_Labs_LabId",
                table: "TestPrices",
                column: "LabId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
