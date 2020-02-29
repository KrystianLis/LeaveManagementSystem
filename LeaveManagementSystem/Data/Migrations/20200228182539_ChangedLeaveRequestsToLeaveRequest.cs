using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagementSystem.Data.Migrations
{
    public partial class ChangedLeaveRequestsToLeaveRequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_LeaveTypes_LeaveTypeId",
                table: "LeaveHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "LeaveHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveHistories",
                table: "LeaveHistories");

            migrationBuilder.RenameTable(
                name: "LeaveHistories",
                newName: "LeaveRequests");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_RequestingEmployeeId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_RequestingEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_LeaveTypeId",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistories_ApprovedById",
                table: "LeaveRequests",
                newName: "IX_LeaveRequests_ApprovedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmployeeId",
                table: "LeaveRequests",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_ApprovedById",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                table: "LeaveRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveRequests_AspNetUsers_RequestingEmployeeId",
                table: "LeaveRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveRequests",
                table: "LeaveRequests");

            migrationBuilder.RenameTable(
                name: "LeaveRequests",
                newName: "LeaveHistories");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_RequestingEmployeeId",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_RequestingEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveRequests_ApprovedById",
                table: "LeaveHistories",
                newName: "IX_LeaveHistories_ApprovedById");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveHistories",
                table: "LeaveHistories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_ApprovedById",
                table: "LeaveHistories",
                column: "ApprovedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_LeaveTypes_LeaveTypeId",
                table: "LeaveHistories",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistories_AspNetUsers_RequestingEmployeeId",
                table: "LeaveHistories",
                column: "RequestingEmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
