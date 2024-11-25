using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium58";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 57.94418d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Manganese58() }, { 1.0d, new BetaParticle(-1, 1917900.0) }, { 0.53d, new GammaParticle(126000.0, 0.00984) }, { 0.00795d, new GammaParticle(174000.0, 0.00713) }, { 0.1325d, new GammaParticle(289500.0, 0.00428) }, { 0.11130000000000001d, new GammaParticle(520400.0, 0.00238) }, { 0.5724d, new GammaParticle(682900.0, 0.00182) } } },

        };
    }
}
    