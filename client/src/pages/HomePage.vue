<script setup>
import Example from '@/components/Example.vue';
import { Pop } from '@/utils/Pop.js';
import { openAIService } from '@/services/openAIService.js'
import { onMounted } from 'vue';


onMounted(() => {
  getMessage()

})
async function getMessage() {
  try {
    await openAIService.getMessage()
  }
  catch (error) {
    Pop.error(error);
  }

}

</script>

<template>
  <Example />
</template>

<style scoped lang="scss"></style>
