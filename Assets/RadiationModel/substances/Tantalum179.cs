using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum179 : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum179";
        public override double halfLife { get; } = 57433652.64d;
        public override double atomicWeight { get; } = 178.94594d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Hafnium179() } },

        };
    }
}
    
    