import { Injectable, Injector } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable } from 'rxjs';
import { AuthService } from '../shared/auth.service';
import { environment } from '../../environments/environment';

@Injectable()
export class HttpRequestInterceptor implements HttpInterceptor {

  constructor(private injector: Injector){
  }
 
  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {

    const authService = this.injector.get(AuthService);
    const isLoggedIn = authService?.token;
      const isApiUrl = request.url.startsWith(environment.apiBaseUrl);
      if (isApiUrl && isLoggedIn) {
          request = request.clone({
            setHeaders: { Authorization: `Bearer ${authService.token}` }
          });
      }

    return next.handle(request);
  }
}
