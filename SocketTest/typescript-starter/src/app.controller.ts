import { Get, Controller } from '@nestjs/common';
import { AppService } from './app.service';
import {WebSocketGateway} from '@nestjs/websockets';

@Controller()
export class AppController {
  constructor(private readonly appService: AppService) {}

  @Get()
  root(): string {
    return this.appService.root();
  }
  
}
