
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium277m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium277m";
        public override double halfLife { get; } = 130.0d;
        public override double atomicWeight { get; } = 277.15189d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    