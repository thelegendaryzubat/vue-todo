<template>
  <v-container>
    <v-card
      class="mx-auto"
      max-width="644"
      outlined>
      <ol class="rounded">
        <li v-for="task in items" v-bind:key="task">
          <a href="#">{{ task}}
          </a>
        </li>
      </ol>
    </v-card>
  </v-container>
</template>

<script lang="ts">
import { Vue } from 'vue-class-component'
import * as signalR from '@microsoft/signalr'

export default class ToDo extends Vue {
  connection = new signalR.HubConnectionBuilder()
    .withUrl('/todo')
    .build()

  items : string [] = []

  created () {
    this.runConnection()
  }

  async runConnection () {
    this.connection.on('Receive', (item: string) => {
      this.items.push(item)
    })
    this.connection.start().catch(err => document.write(err))
  }
}

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
