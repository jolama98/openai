import { logger } from "@/utils/Logger.js"
import { api } from "./AxiosService.js"

class OpenAIService {
  async getMessage() {
    const response = await api.get('api/openai')
    logger.log('LOOK', response.data)
  }
}

export const openAIService = new OpenAIService()
