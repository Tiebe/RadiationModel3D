using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium190m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium190m";
        public override double halfLife { get; } = 4032.0d;
        public override double atomicWeight { get; } = 189.96057d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iridium190() }, { 1.01e-06d, new GammaParticle(26100.0, 0.0475) }, { 0.22521080999999998d, new GammaParticle(10728.0, 0.11557) } } },

        };
    }
}
    