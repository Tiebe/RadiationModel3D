using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Beryllium8i : RadioactiveSubstance
    {
        public override string name { get; } = "Beryllium8i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 8.02315d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Helium4() }, { 1.0d, new AlphaParticle(17740086.220000003) } } },
            { 2.65e-05d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Beryllium8() } } },

        };
    }
}
    