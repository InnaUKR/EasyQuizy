import { Answer } from './answer';
import { UserAnswer } from './userAnswer';

export class Question {
  id: number;
  text: string;
  answersList: Answer[];
  userAnswer?: UserAnswer;
}