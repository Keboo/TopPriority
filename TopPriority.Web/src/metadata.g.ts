import {
  Domain, getEnumMeta, solidify, ModelType, ObjectType,
  PrimitiveProperty, ForeignKeyProperty, PrimaryKeyProperty,
  ModelCollectionNavigationProperty, ModelReferenceNavigationProperty,
  HiddenAreas, BehaviorFlags
} from 'coalesce-vue/lib/metadata'


const domain: Domain = { enums: {}, types: {}, services: {} }
export const ApplicationUser = domain.types.ApplicationUser = {
  name: "ApplicationUser",
  displayName: "Application User",
  get displayProp() { return this.props.name }, 
  type: "model",
  controllerRoute: "ApplicationUser",
  get keyProp() { return this.props.applicationUserId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    applicationUserId: {
      name: "applicationUserId",
      displayName: "Application User Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    name: {
      name: "name",
      displayName: "Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Name is required.",
      }
    },
  },
  methods: {
  },
  dataSources: {
  },
}
export const Ticket = domain.types.Ticket = {
  name: "Ticket",
  displayName: "Ticket",
  get displayProp() { return this.props.ticketId }, 
  type: "model",
  controllerRoute: "Ticket",
  get keyProp() { return this.props.ticketId }, 
  behaviorFlags: 7 as BehaviorFlags,
  props: {
    ticketId: {
      name: "ticketId",
      displayName: "Ticket Id",
      type: "number",
      role: "primaryKey",
      hidden: 3 as HiddenAreas,
    },
    requestorName: {
      name: "requestorName",
      displayName: "Requestor Name",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Requestor Name is required.",
      }
    },
    request: {
      name: "request",
      displayName: "Request",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Request is required.",
      }
    },
    tenant: {
      name: "tenant",
      displayName: "Tenant",
      type: "string",
      role: "value",
      rules: {
        required: val => (val != null && val !== '') || "Tenant is required.",
      }
    },
    createdDateTime: {
      name: "createdDateTime",
      displayName: "Created Date Time",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
    },
    startDateTime: {
      name: "startDateTime",
      displayName: "Start Date Time",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
    },
    completedDateTime: {
      name: "completedDateTime",
      displayName: "Completed Date Time",
      type: "date",
      dateKind: "datetime",
      noOffset: true,
      role: "value",
    },
    isCompleted: {
      name: "isCompleted",
      displayName: "Is Completed",
      type: "boolean",
      role: "value",
      dontSerialize: true,
    },
  },
  methods: {
  },
  dataSources: {
    defaultSource: {
      type: "dataSource",
      name: "DefaultSource",
      displayName: "Default Source",
      isDefault: true,
      props: {
      },
    },
  },
}

interface AppDomain extends Domain {
  enums: {
  }
  types: {
    ApplicationUser: typeof ApplicationUser
    Ticket: typeof Ticket
  }
  services: {
  }
}

solidify(domain)

export default domain as unknown as AppDomain
