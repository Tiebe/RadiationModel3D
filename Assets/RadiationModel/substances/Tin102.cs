using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin102 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin102";
        public override double halfLife { get; } = 3.8d;
        public override double atomicWeight { get; } = 101.93029d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium102() }, { 1.0d, new BetaParticle(1, 7364850.0) }, { 0.225d, new GammaParticle(69000.0, 0.01797) }, { 0.2025d, new GammaParticle(94000.0, 0.01319) }, { 0.05625d, new GammaParticle(238000.0, 0.00521) }, { 0.225d, new GammaParticle(320000.0, 0.00387) }, { 0.0675d, new GammaParticle(538000.0, 0.0023) }, { 0.09d, new GammaParticle(583000.0, 0.00213) }, { 0.0675d, new GammaParticle(844000.0, 0.00147) }, { 0.1125d, new GammaParticle(1063000.0, 0.00117) }, { 0.0675d, new GammaParticle(1107000.0, 0.00112) }, { 0.09d, new GammaParticle(1425000.0, 0.00087) }, { 1.6540000000000001d, new GammaParticle(511000.0, 0.00243) }, { 0.055586314728d, new GammaParticle(3571.0, 0.3472) }, { 0.17285057132529794d, new GammaParticle(24001.0, 0.05166) }, { 0.3242975071769192d, new GammaParticle(24209.0, 0.05121) }, { 0.09099063151074192d, new GammaParticle(27367.0, 0.0453) }, { 0.10827885149778288d, new GammaParticle(27581.0, 0.04495) }, { 0.017288219987040963d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    