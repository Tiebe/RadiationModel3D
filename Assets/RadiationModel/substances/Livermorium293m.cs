using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Livermorium293m : RadioactiveSubstance
    {
        public override string name { get; } = "Livermorium293m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 293.20536d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    