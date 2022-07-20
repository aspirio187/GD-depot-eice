using API.DepotEice.DAL.Entities;
using System.Data;

namespace API.DepotEice.DAL.Mappers
{
    static class Mapper
    {
        public static AppointmentEntity DbToAppointmentEntity(this IDataRecord record)
        {
            return new AppointmentEntity(
                (int)record["Id"],
                (DateTime)record["StartAt"],
                (DateTime)record["EndAt"],
                (bool)record["Accepted"],
                (string)record["UserId"]);
        }

        public static ArticleCommentEntity DbToArticleComment(this IDataRecord record)
        {
            return new ArticleCommentEntity(
                (int)record["Id"],
                (int)record["Note"],
                (string)record["Review"],
                (DateTime)record["CreatedAt"],
                (record["UpdatedAt"] is DBNull) ? null : (DateTime)record["UpdatedAt"],
                (int)record["ArticleId"],
                (string)record["UserId"]);
        }

        public static ArticleEntity DbToArticle(this IDataRecord record)
        {
            return new ArticleEntity(
                (int)record["Id"],
                (string)record["Title"],
                (string)record["Body"],
                (DateTime)record["CreatedAt"],
                (record["UpdatedAt"] is DBNull) ? null : (DateTime)record["UpdatedAt"],
                (bool)record["Pinned"],
                (string)record["UserId"]);
        }

        public static MessageEntity DbToMessage(this IDataRecord record)
        {
            return new MessageEntity(
                (int)record["Id"],
                (string)record["Content"],
                (string)record["SenderId"],
                (string)record["ReceiverId"]);
        }

        public static ModuleEntity DbToModule(this IDataRecord record)
        {
            return new ModuleEntity(
                (int)record["Id"],
                (string)record["Name"],
                (string)record["Description"]);
        }

        public static OpeningHoursEntity DbToOpeningHours(this IDataRecord record)
        {
            return new OpeningHoursEntity(
                id: (int)record["Id"],
                openAt: (DateTime)record["OpenAt"],
                closeAt: (DateTime)record["CloseAt"]);
        }

        public static RoleEntity DbToRole(this IDataRecord record)
        {
            return new RoleEntity(
                (string)record["Id"],
                (string)record["Name"]);
        }

        public static ScheduleFileEntity DbToScheduleFile(this IDataRecord record)
        {
            return new ScheduleFileEntity()
            {
                Id = (int)record["Id"],
                FilePath = (string)record["FilePath"],
                ScheduleId = (int)record["ScheduleId"]
            };
        }

        public static ScheduleEntity DbToSchedule(this IDataRecord record)
        {
            return new ScheduleEntity(
                (int)record["Id"],
                (record["Title"] is DBNull) ? null : (string)record["Title"],
                (record["Details"] is DBNull) ? null : (string)record["Details"],
                (DateTime)record["CreatedAt"],
                (DateTime)record["CreatedAt"],
                (int)record["ModuleId"]);
        }

        // TODO - Check
        // USER
        // User TOKENS
        // ?? M2M usermodules & userroles
    }
}
