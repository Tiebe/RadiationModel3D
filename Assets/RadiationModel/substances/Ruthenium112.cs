using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium112 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium112";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 111.91881d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Rhodium112() }, { 1.0d, new BetaParticle(-1, 2049500.0) }, { 0.0576d, new GammaParticle(82300.0, 0.01506) }, { 0.0018d, new GammaParticle(128000.0, 0.00969) }, { 0.0576d, new GammaParticle(244800.0, 0.00506) }, { 0.18d, new GammaParticle(327000.0, 0.00379) }, { 0.0036d, new GammaParticle(459500.0, 0.0027) }, { 0.01692d, new GammaParticle(588100.0, 0.00211) }, { 0.00284992444118304d, new GammaParticle(2892.0, 0.42871) }, { 0.011367754300413459d, new GammaParticle(20073.0, 0.06177) }, { 0.02152168553656467d, new GammaParticle(20215.0, 0.06133) }, { 0.005844504231751174d, new GammaParticle(22806.0, 0.05436) }, { 0.006814691934221868d, new GammaParticle(22957.0, 0.05401) }, { 0.000970187702470695d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    