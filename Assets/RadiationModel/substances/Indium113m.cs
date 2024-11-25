using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium113m";
        public override double halfLife { get; } = 5968.56d;
        public override double atomicWeight { get; } = 112.90448d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Indium113() }, { 0.6494d, new GammaParticle(391698.0, 0.00317) }, { 0.02244649957056d, new GammaParticle(3571.0, 0.3472) }, { 0.07005415500088544d, new GammaParticle(24001.0, 0.05166) }, { 0.13143368668083572d, new GammaParticle(24209.0, 0.05121) }, { 0.03687735455317552d, new GammaParticle(27367.0, 0.0453) }, { 0.04388405191827886d, new GammaParticle(27581.0, 0.04495) }, { 0.0070066973651033496d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    