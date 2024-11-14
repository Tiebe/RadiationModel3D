using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium39i : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium39i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 38.99458d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    