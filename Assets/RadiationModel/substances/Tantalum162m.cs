
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum162m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum162m";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 161.95742d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    