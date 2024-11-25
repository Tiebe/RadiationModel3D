using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum176m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum176m";
        public override double halfLife { get; } = 0.0011d;
        public override double atomicWeight { get; } = 175.94496d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    