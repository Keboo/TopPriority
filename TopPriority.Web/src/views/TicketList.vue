<template>
  <v-container class="white elevation-1" style="max-width: 900px">
    <v-row no-gutters>
      <h1>Pending Requests</h1>
      <v-spacer />
      <!-- <v-btn large to="/admin/ApplicationUser" color="primary">
        Application User Admin Table
      </v-btn> -->
    </v-row>

    <v-divider class="mt-4" />

    <!--
      <c-table :list="tickets" :admin="true"></c-table>
    -->

    {{ tenant }}
    {{ props.tenant }}

    <v-table>
      <thead>
        <tr>
          <th>Requestor Name</th>
          <th>Request</th>
          <th>Request 2</th>
          <th>Complete?</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in tickets.$items" :key="item.$stableId">
          <td v-text="item.requestorName"></td>
          <td v-text="item.request"></td>
          <td>{{ item.request }}</td>
          <td>{{ item.isCompleted }}</td>
          <td>
            <v-btn
              @click="
                item.completedDateTime = new Date();
                item.$save();
              "
            >
              Save by prop set
            </v-btn>

            <v-btn @click="item.$save({ completedDateTime: new Date() })">
              Save by overrideProps
            </v-btn>
          </td>
        </tr>
      </tbody>
    </v-table>
  </v-container>
</template>

<script setup lang="ts">
import { TicketListViewModel } from "@/viewmodels.g";

const props = defineProps<{
  tenant: string;
}>();

// The properties on the generated ViewModels are already reactive.
// ViewModels and ListViewModels don't need to be wrapped in ref/reactive.
const tickets = new TicketListViewModel();

// useTitle(() => user.name);

//Client side sorting
const sortedItems = computed(() =>
  [...tickets.$items].sort(
    (a, b) =>
      (a.completedDateTime?.valueOf() ?? Infinity) -
      (b.completedDateTime?.valueOf() ?? Infinity)
  )
);

(async function onCreated() {
  //This adds in a parameter into the filter that will be used at the server
  tickets.$params.filter = { tenant: props.tenant };
  await tickets.$load();
})();
</script>
