<template>
  <form v-on:submit.prevent>
    <div class="field">
      <label for="title">Title</label>
      <input type="text" v-model="title" />
    </div>
    <div class="actions">
      <button type="submit" v-on:click="update()">Save Document</button>
    </div>
  </form>
</template>

<script>
import TopicService from "../services/TopicService";

export default {
  name: "update-topic",
  props: ["topicID"],
  data() {
    return {
      title: ""
    };
  },
  methods: {
    update() {
      const topic = { id: this.topicID, title: this.title };
      console.log("Hi?");
      TopicService.update(topic.id,topic)
      .then(response => {
        console.log('I did it?', response.data);
        this.$router.push({name: 'Home'});
      })
      .catch(response => {
        console.error('You failed', response);
      });
    }
  },
  created() {
    TopicService
      .get(this.topicID)
      .then(response => {
        this.$store.commit("SET_ACTIVE_TOPIC", response.data);
        this.title = response.data.title;
      })
      .catch(error => {
        if (error.response.status == 404) {
          this.$router.push("/not-found");
        }
      });
  }
};
</script>

<style>
</style>
