
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium100 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium100";
        public override double halfLife { get; } = 313632.0d;
        public override double atomicWeight { get; } = 99.90852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Rhodium100() } },

        };
    }
}
    
    