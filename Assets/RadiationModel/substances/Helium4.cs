using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Helium4 : RadioactiveSubstance
    {
        public override string name { get; } = "Helium4";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 4.0026d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    