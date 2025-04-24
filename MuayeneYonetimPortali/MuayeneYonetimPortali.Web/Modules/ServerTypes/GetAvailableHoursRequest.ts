import { ServiceRequest } from "@serenity-is/corelib";

export interface GetAvailableHoursRequest extends ServiceRequest {
    DoctorId?: number;
    Date?: string;
}