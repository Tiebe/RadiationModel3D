using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium213 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium213";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 212.99286d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Lead209() }, { 1.0d, new AlphaParticle(9557602.09) }, { 4.4000000000000006e-05d, new GammaParticle(778870.0, 0.00159) }, { 4.530168808e-07d, new GammaParticle(12522.0, 0.09901) }, { 3.435654579277992e-07d, new GammaParticle(72805.0, 0.01703) }, { 5.774209376937802e-07d, new GammaParticle(74970.0, 0.01654) }, { 1.9735422763319557e-07d, new GammaParticle(84986.0, 0.01459) }, { 2.569552043784206e-07d, new GammaParticle(86022.0, 0.01441) }, { 5.9600976745225064e-08d, new GammaParticle(87301.0, 0.0142) } } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    