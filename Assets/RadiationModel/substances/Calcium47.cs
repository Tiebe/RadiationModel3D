using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium47";
        public override double halfLife { get; } = 391910.4d;
        public override double atomicWeight { get; } = 46.95454d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Scandium47() }, { 1.0d, new BetaParticle(-1, 996050.0) }, { 5.561e-05d, new GammaParticle(41060.0, 0.0302) }, { 0.05896d, new GammaParticle(489230.0, 0.00253) }, { 0.0008576d, new GammaParticle(530600.0, 0.00234) }, { 0.0001139d, new GammaParticle(731600.0, 0.00169) }, { 0.0018023d, new GammaParticle(767100.0, 0.00162) }, { 0.05896d, new GammaParticle(807860.0, 0.00153) }, { 0.0001139d, new GammaParticle(1146970.0, 0.00108) }, { 0.67d, new GammaParticle(1297090.0, 0.00096) }, { 0.0002546d, new GammaParticle(1878000.0, 0.00066) }, { 3.599198981923568e-07d, new GammaParticle(422.0, 2.93801) }, { 4.650840889728432e-06d, new GammaParticle(4086.0, 0.30344) }, { 9.175065870444728e-06d, new GammaParticle(4091.0, 0.30307) }, { 1.8236371016668398e-06d, new GammaParticle(4474.0, 0.27712) }, { 1.8236371016668398e-06d, new GammaParticle(4474.0, 0.27712) } } },

        };
    }
}
    