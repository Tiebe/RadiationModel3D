
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium255";
        public override double halfLife { get; } = 0.054d;
        public override double atomicWeight { get; } = 255.10693d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.67d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    