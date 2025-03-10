# ResultExtension
This is a .NET library for implementing Result pattern.

## Features
- Easy-to-use result types.
- Supports .NET 9.0 and later.

## Installation
```bash
dotnet add package Hilton.ResultExtension
```

## Usage
```CSharp
public async Task<Result<YourEntityType>> GetById(Guid id, CancellationToken cancellationToken)
    {
        var post = await _context.Posts
            .Include(x => x.PostCategories)
            .ThenInclude(x => x.Category)
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (post is null)
        {
            return Result<YourEntityType>.Failed($"{nameof(YourEntityType)} с Id: {id} не найден.", ResultType.NotFound)!;
        }

        return Result<YourEntityType>.Success(post);
    }
```
