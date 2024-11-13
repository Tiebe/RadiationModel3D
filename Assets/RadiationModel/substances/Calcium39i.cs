
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium39i : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium39i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 38.97754d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    