using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin106 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin106";
        public override double halfLife { get; } = 115.0d;
        public override double atomicWeight { get; } = 105.91696d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium106() }, { 1.0d, new BetaParticle(1, 4889100.0) }, { 0.01972d, new GammaParticle(49300.0, 0.02515) }, { 0.02291d, new GammaParticle(52500.0, 0.02362) }, { 0.013340000000000001d, new GammaParticle(101900.0, 0.01217) }, { 0.1334d, new GammaParticle(122300.0, 0.01014) }, { 0.1305d, new GammaParticle(224100.0, 0.00553) }, { 0.29d, new GammaParticle(253200.0, 0.0049) }, { 0.0406d, new GammaParticle(326200.0, 0.0038) }, { 0.00986d, new GammaParticle(355000.0, 0.00349) }, { 0.3886d, new GammaParticle(386500.0, 0.00321) }, { 0.2697d, new GammaParticle(477200.0, 0.0026) }, { 0.1392d, new GammaParticle(712300.0, 0.00174) }, { 0.2407d, new GammaParticle(863800.0, 0.00144) }, { 0.00986d, new GammaParticle(1096300.0, 0.00113) }, { 0.19140000000000001d, new GammaParticle(1189600.0, 0.00104) }, { 0.0203d, new GammaParticle(1419400.0, 0.00087) }, { 1.99d, new GammaParticle(511000.0, 0.00243) }, { 0.01260985045392d, new GammaParticle(3571.0, 0.3472) }, { 0.042993175109864695d, new GammaParticle(24001.0, 0.05166) }, { 0.08066261746691313d, new GammaParticle(24209.0, 0.05121) }, { 0.022632127414472444d, new GammaParticle(27367.0, 0.0453) }, { 0.026932231623222207d, new GammaParticle(27581.0, 0.04495) }, { 0.004300104208749764d, new GammaParticle(27858.0, 0.04451) } } },

        };
    }
}
    