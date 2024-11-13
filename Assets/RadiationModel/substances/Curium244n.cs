
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium244n : RadioactiveSubstance
    {
        public override string name { get; } = "Curium244n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 244.06393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    