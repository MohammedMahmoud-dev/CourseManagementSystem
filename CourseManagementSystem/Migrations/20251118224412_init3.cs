using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userNotifications_AspNetUsers_RecipientId",
                table: "userNotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_userNotifications_Notifications_NotificationId",
                table: "userNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userNotifications",
                table: "userNotifications");

            migrationBuilder.RenameTable(
                name: "userNotifications",
                newName: "UserNotifications");

            migrationBuilder.RenameIndex(
                name: "IX_userNotifications_RecipientId_NotificationId",
                table: "UserNotifications",
                newName: "IX_UserNotifications_RecipientId_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_userNotifications_NotificationId",
                table: "UserNotifications",
                newName: "IX_UserNotifications_NotificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserNotifications",
                table: "UserNotifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserNotifications_AspNetUsers_RecipientId",
                table: "UserNotifications",
                column: "RecipientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserNotifications_Notifications_NotificationId",
                table: "UserNotifications",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserNotifications_AspNetUsers_RecipientId",
                table: "UserNotifications");

            migrationBuilder.DropForeignKey(
                name: "FK_UserNotifications_Notifications_NotificationId",
                table: "UserNotifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserNotifications",
                table: "UserNotifications");

            migrationBuilder.RenameTable(
                name: "UserNotifications",
                newName: "userNotifications");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_RecipientId_NotificationId",
                table: "userNotifications",
                newName: "IX_userNotifications_RecipientId_NotificationId");

            migrationBuilder.RenameIndex(
                name: "IX_UserNotifications_NotificationId",
                table: "userNotifications",
                newName: "IX_userNotifications_NotificationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userNotifications",
                table: "userNotifications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_userNotifications_AspNetUsers_RecipientId",
                table: "userNotifications",
                column: "RecipientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userNotifications_Notifications_NotificationId",
                table: "userNotifications",
                column: "NotificationId",
                principalTable: "Notifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
