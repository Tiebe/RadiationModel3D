
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lawrencium261 : RadioactiveSubstance
    {
        public override string name { get; } = "Lawrencium261";
        public override double halfLife { get; } = 2340.0d;
        public override double atomicWeight { get; } = 261.10688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    