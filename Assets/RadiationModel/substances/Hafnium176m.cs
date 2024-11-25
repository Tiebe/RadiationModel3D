using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 175.94284d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    