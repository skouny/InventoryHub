# InventoryHub

An inventory management system built with Blazor WebAssembly (front-end) and ASP.NET Core Minimal API (back-end). This project demonstrates full-stack development with Microsoft Copilot assistance across four progressive activities.

## Project Structure

- **ClientApp**: Blazor WebAssembly front-end application
- **ServerApp**: ASP.NET Core Minimal API back-end application

## Features

- 📦 View product list with details (Name, Price, Stock, Category)
- 🔗 RESTful API integration between frontend and backend
- ⚡ Client-side and server-side caching for optimal performance
- 🛡️ Comprehensive error handling for network and data issues
- 🎨 Modern, responsive UI with Bootstrap
- 📊 Nested JSON structures with product categories

## Development Journey

This project was completed through four progressive activities:

### Activity 1: Integration Code

- Generated integration code for seamless frontend-backend communication
- Implemented HttpClient configuration in Blazor
- Created product list component with async data fetching
- Established CORS configuration

### Activity 2: Debugging

- Fixed API route mismatch (/api/products → /api/productlist)
- Enhanced error handling with specific exception types
- Implemented robust JSON deserialization with error recovery
- Added console logging for debugging

### Activity 3: JSON Structuring

- Extended API response to include nested Category objects
- Updated frontend models to support hierarchical data
- Improved UI to display category information
- Validated JSON structure against industry standards

### Activity 4: Performance Optimization

- Implemented server-side output caching (60-second TTL)
- Added client-side static caching to prevent redundant API calls
- Documented code with detailed comments explaining Copilot contributions
- Created comprehensive reflection on the development process

## Getting Started

### API Endpoints

- `GET /api/productlist` - Returns a list of products with nested category objects

### Testing the API

You can test the API directly using:

- Browser: Navigate to `http://localhost:5074/api/productlist`
- Postman: Send GET request to the same endpoint
- cURL: `curl http://localhost:5074/api/productlist`

## Project Configuration

### Performance Optimizations

- **Server-side**: Output caching with 60-second expiration reduces server load
- **Client-side**: Static cache prevents redundant API calls during navigation
- **Response Caching**: Middleware configured for efficient response handling

### Error Handling

The application includes comprehensive error handling for:

- Network errors (server not running)
- HTTP errors (invalid responses, 404, 500, etc.)
- JSON deserialization errors (malformed data)
- Timeout errors
- Unexpected exceptions

All errors are logged to the console and displayed to users with clear, actionable messages.

### CORS Configuration

Cross-Origin Resource Sharing (CORS) is configured to allow:

- Any origin (suitable for development; restrict in production)
- Any HTTP method (GET, POST, PUT, DELETE, etc.)
- Any header

## Key Files

- `ServerApp/Program.cs` - API endpoints, CORS, and caching configuration
- `ClientApp/Pages/FetchProducts.razor` - Product list component with data fetching
- `ClientApp/Layout/NavMenu.razor` - Navigation menu
- `REFLECTION.md` - Detailed reflection on the development process and Copilot usage

## Code Documentation

The codebase includes extensive comments documenting:

- How Microsoft Copilot assisted in each activity
- Specific optimizations and suggestions from Copilot
- Best practices learned during development
- Rationale for key architectural decisions

## Performance Metrics

With caching enabled:

- Reduced API calls by ~90% for repeat page visits
- Server response time improved with output caching
- Better user experience with instant data display from cache

## Future Enhancements

Potential improvements for this project:

- Add CRUD operations (Create, Update, Delete products)
- Implement authentication and authorization
- Connect to a real database instead of in-memory data
- Add product search and filtering capabilities
- Implement real-time updates with SignalR
- Add unit and integration tests
- Deploy to Azure or other cloud platform

## Learning Outcomes

This project demonstrates:

- Full-stack development with .NET technologies
- Effective use of AI-assisted development with Microsoft Copilot
- RESTful API design and consumption
- Error handling and debugging strategies
- Performance optimization techniques
- Modern web UI development with Blazor
- JSON data structure design

## Reflection

For a detailed reflection on the development process and how Microsoft Copilot contributed to this project, see [REFLECTION.md](REFLECTION.md).

## License

This project is for educational purposes.
