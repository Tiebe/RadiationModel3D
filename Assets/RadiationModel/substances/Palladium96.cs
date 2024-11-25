using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium96";
        public override double halfLife { get; } = 122.0d;
        public override double atomicWeight { get; } = 95.91821d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Ruthenium96() }, { 1.0d, new BetaParticle(1, 4948695.0) }, { 0.657d, new GammaParticle(124900.0, 0.00993) }, { 0.0022995d, new GammaParticle(163800.0, 0.00757) }, { 0.001971d, new GammaParticle(289000.0, 0.00429) }, { 0.009855000000000001d, new GammaParticle(336100.0, 0.00369) }, { 0.180675d, new GammaParticle(499700.0, 0.00248) }, { 0.05256d, new GammaParticle(598800.0, 0.00207) }, { 0.010511999999999999d, new GammaParticle(625300.0, 0.00198) }, { 0.164907d, new GammaParticle(723400.0, 0.00171) }, { 0.505233d, new GammaParticle(762300.0, 0.00163) }, { 0.022338d, new GammaParticle(788900.0, 0.00157) }, { 0.003942d, new GammaParticle(862300.0, 0.00144) }, { 0.025623d, new GammaParticle(887100.0, 0.0014) }, { 0.005913000000000001d, new GammaParticle(1008800.0, 0.00123) }, { 0.00657d, new GammaParticle(1026700.0, 0.00121) }, { 0.17476199999999997d, new GammaParticle(1098700.0, 0.00113) }, { 0.031536d, new GammaParticle(1223400.0, 0.00101) }, { 0.019710000000000002d, new GammaParticle(1388500.0, 0.00089) }, { 0.037448999999999996d, new GammaParticle(1625600.0, 0.00076) }, { 0.6778d, new GammaParticle(511000.0, 0.00243) }, { 0.0373816340066d, new GammaParticle(2892.0, 0.42871) }, { 0.15775984239754076d, new GammaParticle(20073.0, 0.06177) }, { 0.29867444603850957d, new GammaParticle(20215.0, 0.06133) }, { 0.08110907767062576d, new GammaParticle(22806.0, 0.05436) }, { 0.09457318456394964d, new GammaParticle(22957.0, 0.05401) }, { 0.013464106893323877d, new GammaParticle(23170.0, 0.05351) } } },

        };
    }
}
    