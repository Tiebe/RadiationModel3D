using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum193m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum193m";
        public override double halfLife { get; } = 374112.0d;
        public override double atomicWeight { get; } = 192.96315d;

        public override Dictionary<double, List<KeyValuePair<double, RadioactiveSubstance>>> decayProducts { get; } = new()
        {
            { 1.0d, new List<KeyValuePair<double, RadioactiveSubstance>> { new(1.0d, new Platinum193()), new(0.00032099999999999994d, new GammaParticle(1642.0, 0.75508)), new(0.006999999999999999d, new GammaParticle(12634.0, 0.09814)), new(0.001145d, new GammaParticle(135500.0, 0.00915)), new(0.27366749d, new GammaParticle(11070.0, 0.112)), new(0.04309714502367789d, new GammaParticle(65122.0, 0.01904)), new(0.07367033337380836d, new GammaParticle(66832.0, 0.01855)), new(0.024788119442079117d, new GammaParticle(75821.0, 0.01635)), new(0.031877521602513746d, new GammaParticle(76725.0, 0.01616)), new(0.007089402160434628d, new GammaParticle(77832.0, 0.01593)) } },

        }; 
        
        public static Dictionary<double, double> betaPlusSpectrum { get; } = new()
        {

        }; 
        public static Dictionary<double, double> betaMinusSpectrum { get; } = new()
        {

        }; 
    }
}
    