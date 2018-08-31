using System;
using System.Collections.Generic;
using EncompassRest.Loans.Enums;
using EncompassRest.Schema;

namespace EncompassRest.Loans
{
    /// <summary>
    /// CustomModelFields
    /// </summary>
    public sealed partial class CustomModelFields : ExtensibleObject, IIdentifiable
    {
        private DirtyValue<string> _id;
        /// <summary>
        /// CustomModelFields Id
        /// </summary>
        public string Id { get => _id; set => SetField(ref _id, value); }
        private DirtyValue<bool?> _provideAmortizationScenario;
        /// <summary>
        /// CustomModelFields ProvideAmortizationScenario
        /// </summary>
        public bool? ProvideAmortizationScenario { get => _provideAmortizationScenario; set => SetField(ref _provideAmortizationScenario, value); }
        private DirtyValue<bool?> _provideBestCaseScenario;
        /// <summary>
        /// CustomModelFields ProvideBestCaseScenario
        /// </summary>
        public bool? ProvideBestCaseScenario { get => _provideBestCaseScenario; set => SetField(ref _provideBestCaseScenario, value); }
        private DirtyValue<bool?> _provideFHAScenario;
        /// <summary>
        /// CustomModelFields ProvideFHAScenario
        /// </summary>
        public bool? ProvideFHAScenario { get => _provideFHAScenario; set => SetField(ref _provideFHAScenario, value); }
        private DirtyValue<bool?> _provideWorstCaseScenario;
        /// <summary>
        /// CustomModelFields ProvideWorstCaseScenario
        /// </summary>
        public bool? ProvideWorstCaseScenario { get => _provideWorstCaseScenario; set => SetField(ref _provideWorstCaseScenario, value); }
    }
}