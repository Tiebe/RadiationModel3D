
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium101";
        public override double halfLife { get; } = 128436794.64d;
        public override double atomicWeight { get; } = 100.90616d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new Ruthenium101() } },

        };
    }
}
    
    