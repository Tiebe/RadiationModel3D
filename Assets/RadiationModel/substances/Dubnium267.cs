using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium267 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium267";
        public override double halfLife { get; } = 7200.0d;
        public override double atomicWeight { get; } = 267.12239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    