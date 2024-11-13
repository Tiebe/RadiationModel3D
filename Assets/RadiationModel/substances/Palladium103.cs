
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium103 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium103";
        public override double halfLife { get; } = 1468022.4d;
        public override double atomicWeight { get; } = 102.90611d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Rhodium103() } },

        };
    }
}
    
    