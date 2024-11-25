using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium186 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium186";
        public override double halfLife { get; } = 321278.4d;
        public override double atomicWeight { get; } = 185.95499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.925d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Osmium186() }, { 1.0d, new BetaParticle(-1, 536349.99999) }, { 0.0947d, new GammaParticle(137150.0, 0.00904) }, { 7.4e-09d, new GammaParticle(143170.0, 0.00866) }, { 5.3e-07d, new GammaParticle(296900.0, 0.00418) }, { 6.2e-07d, new GammaParticle(333400.0, 0.00372) }, { 1.5000000000000002e-08d, new GammaParticle(476400.0, 0.0026) }, { 0.000292d, new GammaParticle(630330.0, 0.00197) }, { 0.000329d, new GammaParticle(767470.0, 0.00162) }, { 2.1999999999999998e-07d, new GammaParticle(773500.0, 0.0016) }, { 0.02882844536852588d, new GammaParticle(10393.0, 0.1193) }, { 0.011365165106616925d, new GammaParticle(61486.0, 0.02016) }, { 0.019584982089637992d, new GammaParticle(63000.0, 0.01968) }, { 0.006552726476707097d, new GammaParticle(71496.0, 0.01734) }, { 0.008387489890185083d, new GammaParticle(72338.0, 0.01714) }, { 0.0018347634134779872d, new GammaParticle(73364.0, 0.0169) } } },
            { 0.075d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten186() }, { 0.006026d, new GammaParticle(122640.0, 0.01011) }, { 0.0195697748557d, new GammaParticle(9740.0, 0.12729) }, { 0.0172989540009946d, new GammaParticle(57983.0, 0.02138) }, { 0.03004855654159215d, new GammaParticle(59320.0, 0.0209) }, { 0.009960072861391875d, new GammaParticle(67335.0, 0.01841) }, { 0.01268913282541325d, new GammaParticle(68117.0, 0.0182) }, { 0.002729059964021374d, new GammaParticle(69068.0, 0.01795) } } },

        };
    }
}
    