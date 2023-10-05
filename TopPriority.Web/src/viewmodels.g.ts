import * as $metadata from './metadata.g'
import * as $models from './models.g'
import * as $apiClients from './api-clients.g'
import { ViewModel, ListViewModel, ServiceViewModel, DeepPartial, defineProps } from 'coalesce-vue/lib/viewmodel'

export interface ApplicationUserViewModel extends $models.ApplicationUser {
  applicationUserId: number | null;
  name: string | null;
}
export class ApplicationUserViewModel extends ViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, number> implements $models.ApplicationUser  {
  
  constructor(initialData?: DeepPartial<$models.ApplicationUser> | null) {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient(), initialData)
  }
}
defineProps(ApplicationUserViewModel, $metadata.ApplicationUser)

export class ApplicationUserListViewModel extends ListViewModel<$models.ApplicationUser, $apiClients.ApplicationUserApiClient, ApplicationUserViewModel> {
  
  constructor() {
    super($metadata.ApplicationUser, new $apiClients.ApplicationUserApiClient())
  }
}


export interface TicketViewModel extends $models.Ticket {
  ticketId: number | null;
  requestorName: string | null;
  request: string | null;
  tenant: string | null;
  createdDateTime: Date | null;
  startDateTime: Date | null;
  completedDateTime: Date | null;
  isCompleted: boolean | null;
}
export class TicketViewModel extends ViewModel<$models.Ticket, $apiClients.TicketApiClient, number> implements $models.Ticket  {
  
  constructor(initialData?: DeepPartial<$models.Ticket> | null) {
    super($metadata.Ticket, new $apiClients.TicketApiClient(), initialData)
  }
}
defineProps(TicketViewModel, $metadata.Ticket)

export class TicketListViewModel extends ListViewModel<$models.Ticket, $apiClients.TicketApiClient, TicketViewModel> {
  
  constructor() {
    super($metadata.Ticket, new $apiClients.TicketApiClient())
  }
}


const viewModelTypeLookup = ViewModel.typeLookup = {
  ApplicationUser: ApplicationUserViewModel,
  Ticket: TicketViewModel,
}
const listViewModelTypeLookup = ListViewModel.typeLookup = {
  ApplicationUser: ApplicationUserListViewModel,
  Ticket: TicketListViewModel,
}
const serviceViewModelTypeLookup = ServiceViewModel.typeLookup = {
}

