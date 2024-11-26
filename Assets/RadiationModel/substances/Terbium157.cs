using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium157 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium157";
        public override double halfLife { get; } = 2240541744.19603d;
        public override double atomicWeight { get; } = 156.92403d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gadolinium157() }, { 8.4e-05d, new GammaParticle(54500.0, 0.02275) }, { 0.000149621472d, new GammaParticle(6858.0, 0.18079) }, { 0.00021213192690866536d, new GammaParticle(42308.0, 0.02931) }, { 0.00038160087589254426d, new GammaParticle(42996.0, 0.02884) }, { 0.00012062694948439461d, new GammaParticle(48802.0, 0.02541) }, { 0.0001523518371987904d, new GammaParticle(49326.0, 0.02514) }, { 3.172488771439578e-05d, new GammaParticle(49957.0, 0.02482) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    