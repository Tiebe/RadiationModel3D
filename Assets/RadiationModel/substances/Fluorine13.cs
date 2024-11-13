
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine13 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine13";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 13.04512d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    