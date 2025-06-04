# 💸 Finance Dashboard 📈

A personal finance app to track bills, income, and forecast account balances. Built with .NET 8 and PostgreSQL. Eventually will include a React frontend, but currently focused on building a clean, modular backend.

I outgrew Excel/Numbers for budgeting and I wanted something to visualize cash flow, track actual vs. estimated transactions, and better understand upcoming bills/debts.

## 🚧 Features (In Progress)

- Add/edit recurring bills and income sources
- View estimated vs. actual amounts
- Forecast future balances month-to-month
- Track debt utilization and interest
- Modular .NET 8 backend with PostgreSQL

## 🤔 Future Plans

- React frontend with responsive layout
- Passwordless auth using Clerk.dev
- CI/CD with GitHub Actions
- Hosted version with mobile-friendly interface

## 🛠️ Requirements
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

## 🚀 Getting Started

### Clone Repo

```bash
git clone https://github.com/BrandonSchreck/finance-dashboard
cd finance-dashboard
```

### Setup .env File

Copy the [.env.example](./env.example) file:

```bash
cp .env.example .env
```

Edit the `.env` file with your database credentials:

```env
# Postgres DB Configuration
POSTGRES_DB=your_db_here
POSTGRES_USER=your_user_here
POSTGRES_PASSWORD=your_password_here
```

### Start the database and [Adminer](https://www.adminer.org/en/) (local DB viewer)

```bash
docker compose up -d
```

### Run the API
```bash
cd backend/FinanceDashboard.WebApi

# Apply database migrations (first run or after new migrations)
dotnet ef database update

# Run API
dotnet watch
```

## Tech Stack

- Docker
- PostgreSQL
- .NET 8 Minimal API
- EF Core
- React (Planned)

## License

This project is licensed under the [MIT License](LICENSE).