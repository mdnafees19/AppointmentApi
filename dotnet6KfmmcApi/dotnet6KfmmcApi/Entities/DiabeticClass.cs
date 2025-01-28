using Microsoft.EntityFrameworkCore;

namespace dotnet6KfmmcApi.Entity
{
    [Keyless]
    public class DiabeticClass
    {
        //[Key]
        //public int ID { get; set; }
        
        public string? PATNO { get; set; }
        public string? P_FAM_NAME { get; set; }
        public string? P_GIVEN { get; set; }
        public string? DOB { get; set; }
        public string? GENDER { get; set; }
        public double? AGE { get; set; }
        public string? NATIONALID { get; set; }
        public double? ROOM_NO { get; set; }
        public string? CONTACT_NUMBER { get; set; }
        public string? RACE { get; set; }
        public string? NID { get; set; }
        public string? EMP_NO { get; set; }
        public string? NAME { get; set; }
        public string? MOBILE_NO { get; set; }
        public double? H_CENTER { get; set; }
        public double? CLINIC { get; set; }
        public string? P_ON_WHEELCHAIR { get; set; }
        public double? HEIGHT { get; set; }
        public double? WEIGHT { get; set; }
        public string? DATE_OF_DIAG { get; set; }
        public double? DUR_OF_DIAG { get; set; }
        public double? ASCVD_SCORE { get; set; }
        public double? SMOKING { get; set; }
        public string? SEVERE_HYPOGLYCEMIA_HIST { get; set; }
        public double? SYSTOLIC_BP { get; set; }
        public double? DIASTOLIC_BP { get; set; }
        public string? DATE_OF_BP { get; set; }
        public double? EGFR { get; set; }
        public string? DATE_OF_EGFR { get; set; }
        public string? VALUE_ALBUMIN_CREATININ_CHKD { get; set; }
        public string? EGFR_ANNUAL_NO_CKD { get; set; }
        public string? HBA1C_REQUESTED_TWICE_YEAR { get; set; }
        public int DIAB_YEAR { get; set; }
        public int SLEEP_PATTERN { get; set; }
        public string? SLEEP_PAT_COMM { get; set; }
        public int EATING_PATTERN { get; set; }
        public string? EATING_PAT_COMM { get; set; }
        public string? EXERCISE { get; set; }
        public string? EXERCISE_COMM { get; set; }
        public string? ED_VISIT_DMC { get; set; }
        public string? ED_VISIT_REASON_ID { get; set; }
        public string? ED_VISIT_OTHER_COMM { get; set; }
        public string? DIABETIC_HISTORY_OPTIONS { get; set; }
        public string? DIABETIC_HISTORY_OTHER { get; set; }
        public string? EYE_EXAM { get; set; }
        public string? EYE_EXAM_DATE { get; set; }
        public double? EYE_RIGHT_EXAM_RESULT { get; set; }
        public double? EYE_LEFT_EXAM_RESULT { get; set; }
        public string? EYE_RIGHT_EXAM_RESULT_COMM { get; set; }
        public string? EYE_LEFT_EXAM_RESULT_COMM { get; set; }
        public double? EYE_RIGHT_NPDR_SEVERITY { get; set; }
        public double? EYE_LEFT_NPDR_EYE_RIGHT { get; set; }
        public string? EYE_LEFT_PDR { get; set; }
        public string? EYE_RIGHT_PDR { get; set; }
        public string? EYE_LEFT_MEDEMA { get; set; }
        public string? EYE_RIGHT_MEDEMA { get; set; }
        public string? RIGHT_EYE_EXAM_CLASS_ID { get; set; }
        public string? Left_EYE_EXAM_CLASS_ID { get; set; }
        //public string? FOOT_EXAM_RESULT { get; set; }
        public string? LAST_FOOT_EXAM_DATE { get; set; }
        public double? FOOT_RIGHT_EXAM { get; set; }
        public double? FOOT_LEFT_EXAM { get; set; }
        public string? FOOT_RIGHT_ULCER_COMM { get; set; }
        public string? FOOT_LEFT_ULCER_COMM { get; set; }
        public double? NEUROPATHY_SCREENING_RIGHT { get; set; }
        public double? NEUROPATHY_SCREENING_LEFT { get; set; }
        public string? NPS_RIGHT_ABNORMAL_COMM { get; set; }
        public string? NPS_LEFT_ABNORMAL_COMM { get; set; }
        public string? LEFT_FOOT_EXAM_DATE { get; set; }
        public string? RIGHT_FOOT_EXAM_DATE { get; set; }
        public string? RIGHT_FOOT_COND { get; set; }
        public string? LEFT_FOOT_COND { get; set; }
        public string? NEUROPATHY_EXAM_DATE { get; set; }
        public string? FOOT_EXAM { get; set; }
        public int FLU_VACCIN { get; set; }
        public string? FLU_VACCIN_DATE { get; set; }
        public int PNEUMOCOCCUS_VACCIN { get; set; }
        public string? PNEUMOCOCCUS_VACCIN_DATE { get; set; }
        public string? VACCIN_OTHER_COMM { get; set; }
        public string? ACEI_ARB { get; set; }
        public string? ACE_ARB_USED_COMM { get; set; }
        public string? STATIN_USE { get; set; }
        public string? STATIN_USED_COMM { get; set; }
        public string? INSULIN_USED { get; set; }
        public string? INSULIN_USED_COM { get; set; }
        public int MED_COMPLIANCE { get; set; }
        public string? MED_COMP_COM { get; set; }
        public string? MED_COMP_NAME { get; set; }
        public string? MED_SIDE_EFFECT { get; set; }
        public string? MED_SIDE_EFFECT_COMM { get; set; }
        public string? MED_SIDE_EFFECT_NAME { get; set; }
        public string? ANTIPLATELET_USED_HX { get; set; }
        public string? ANTIPLATELET_USED_COMM { get; set; }
        public string? GLPI_CLASS_USED { get; set; }
        public string? GLPI_CLASS_USED_COM { get; set; }
        public string? SGLT2_INHIBITOR_USED { get; set; }
        public string? SGLT2_INHIBITOR_USED_COM { get; set; }
        public double? HBA1C_SOURCE { get; set; }
        public double? HBA1C { get; set; }
        public string? HBA1C_TEST_DATE { get; set; }
        public double? LDL { get; set; }
        public string? LAST_LDL_DATE { get; set; }
        public double? HDL { get; set; }
        public string? LAST_HDL_DATE { get; set; }
        public double? TOTAL_CHOLESTEROL { get; set; }
        public string? LAST_TOT_CHOL_DATE { get; set; }
        public double? ACR { get; set; }
        public string? LAST_ACR_DATE { get; set; }
        public string? CREATED_BY { get; set; }
        public string? UPDATED_BY { get; set; }
        public string? CREATED_DATE { get; set; }
        public string? CREATEDBY { get; set; }



    }
}
