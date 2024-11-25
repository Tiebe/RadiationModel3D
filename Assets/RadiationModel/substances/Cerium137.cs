using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium137";
        public override double halfLife { get; } = 32400.0d;
        public override double atomicWeight { get; } = 136.90776d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Barium137() }, { 1.0d, new BetaParticle(1, 901300.0) }, { 0.008248799999999999d, new GammaParticle(10610.0, 0.11686) }, { 8.400000000000001e-06d, new GammaParticle(148830.0, 0.00833) }, { 3.696e-05d, new GammaParticle(217030.0, 0.00571) }, { 0.00048888d, new GammaParticle(433220.0, 0.00286) }, { 0.0025031999999999997d, new GammaParticle(436590.0, 0.00284) }, { 0.0168d, new GammaParticle(447150.0, 0.00277) }, { 0.00011256d, new GammaParticle(479120.0, 0.00259) }, { 0.00043176d, new GammaParticle(482470.0, 0.00257) }, { 9.912000000000001e-05d, new GammaParticle(493030.0, 0.00251) }, { 3.36e-06d, new GammaParticle(529300.0, 0.00234) }, { 0.000126d, new GammaParticle(631380.0, 0.00196) }, { 8.400000000000001e-06d, new GammaParticle(678260.0, 0.00183) }, { 0.000294d, new GammaParticle(698720.0, 0.00177) }, { 1.008e-05d, new GammaParticle(709300.0, 0.00175) }, { 6.72e-06d, new GammaParticle(724400.0, 0.00171) }, { 5.712e-05d, new GammaParticle(770970.0, 0.00161) }, { 2.856e-05d, new GammaParticle(781570.0, 0.00159) }, { 0.00048551999999999997d, new GammaParticle(915800.0, 0.00135) }, { 0.00031919999999999995d, new GammaParticle(926350.0, 0.00134) }, { 1.4112e-05d, new GammaParticle(1160850.0, 0.00107) }, { 0.00017d, new GammaParticle(511000.0, 0.00243) }, { 0.19133072865996373d, new GammaParticle(5185.0, 0.23912) }, { 0.21732656171942882d, new GammaParticle(33034.0, 0.03753) }, { 0.3992038238784512d, new GammaParticle(33442.0, 0.03707) }, { 0.11887768648080435d, new GammaParticle(37908.0, 0.03271) }, { 0.14895374116044782d, new GammaParticle(38273.0, 0.03239) }, { 0.030076054679643503d, new GammaParticle(38725.0, 0.03202) } } },

        };
    }
}
    