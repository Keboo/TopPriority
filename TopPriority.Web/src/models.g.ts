import * as metadata from './metadata.g'
import { Model, DataSource, convertToModel, mapToModel } from 'coalesce-vue/lib/model'

export interface ApplicationUser extends Model<typeof metadata.ApplicationUser> {
  applicationUserId: number | null
  name: string | null
}
export class ApplicationUser {
  
  /** Mutates the input object and its descendents into a valid ApplicationUser implementation. */
  static convert(data?: Partial<ApplicationUser>): ApplicationUser {
    return convertToModel(data || {}, metadata.ApplicationUser) 
  }
  
  /** Maps the input object and its descendents to a new, valid ApplicationUser implementation. */
  static map(data?: Partial<ApplicationUser>): ApplicationUser {
    return mapToModel(data || {}, metadata.ApplicationUser) 
  }
  
  /** Instantiate a new ApplicationUser, optionally basing it on the given data. */
  constructor(data?: Partial<ApplicationUser> | {[k: string]: any}) {
    Object.assign(this, ApplicationUser.map(data || {}));
  }
}


export interface Ticket extends Model<typeof metadata.Ticket> {
  ticketId: number | null
  requestorName: string | null
  request: string | null
  tenant: string | null
  createdDateTime: Date | null
  startDateTime: Date | null
  completedDateTime: Date | null
  isCompleted: boolean | null
}
export class Ticket {
  
  /** Mutates the input object and its descendents into a valid Ticket implementation. */
  static convert(data?: Partial<Ticket>): Ticket {
    return convertToModel(data || {}, metadata.Ticket) 
  }
  
  /** Maps the input object and its descendents to a new, valid Ticket implementation. */
  static map(data?: Partial<Ticket>): Ticket {
    return mapToModel(data || {}, metadata.Ticket) 
  }
  
  /** Instantiate a new Ticket, optionally basing it on the given data. */
  constructor(data?: Partial<Ticket> | {[k: string]: any}) {
    Object.assign(this, Ticket.map(data || {}));
  }
}
export namespace Ticket {
  export namespace DataSources {
    
    export class DefaultSource implements DataSource<typeof metadata.Ticket.dataSources.defaultSource> {
      readonly $metadata = metadata.Ticket.dataSources.defaultSource
    }
  }
}


