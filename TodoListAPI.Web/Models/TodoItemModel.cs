using TodoListAPI.Domain.Entities;
using TodoListAPI.Domain.Enums;

namespace TodoListAPI.Web.Models;

public record TodoItemModel(Guid Id,
                            string Description,
                            ItemStatus Status,
                            Guid TodoListId,
                            string TodoListName,
                            ItemCategoryModel ItemCategory,
                            List<ItemTagModel> ItemTags);

