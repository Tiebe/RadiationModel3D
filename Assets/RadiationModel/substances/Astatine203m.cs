using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine203m : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine203m";
        public override double halfLife { get; } = 0.0035d;
        public override double atomicWeight { get; } = 202.98768d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    