
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium55 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium55";
        public override double halfLife { get; } = 0.01d;
        public override double atomicWeight { get; } = 55.0005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    