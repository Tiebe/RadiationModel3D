using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium234";
        public override double halfLife { get; } = 139.2d;
        public override double atomicWeight { get; } = 234.04773d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Plutonium234() } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    